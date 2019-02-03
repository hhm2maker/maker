﻿using Maker.Business.Model.OperationModel;
using Maker.Business.ScriptUserControlBusiness;
using Maker.Model;
using Maker.View.LightScriptUserControl;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Maker.Business.ViewBusiness.Currency
{
    public class ScriptFileBusiness
    {
        public static List<Light> FileToLight(String filePath) {
            Dictionary < string, List < Light >> mLights = Test(GetScriptModelDictionary(filePath));
            List<Light> lights = new List<Light>();
            foreach (var item in mLights) {
                lights.AddRange(item.Value);
            }
            return lights;
        }

        public static Dictionary<String, ScriptModel> GetScriptModelDictionary(String filePath)
        {
            Dictionary<String, ScriptModel> scriptModelDictionary = new Dictionary<string, ScriptModel>();
            XDocument xDoc = XDocument.Load(filePath);
            XElement xRoot = xDoc.Element("Root");
            XElement xScripts = xRoot.Element("Scripts");
            foreach (var xScript in xScripts.Elements("Script"))
            {
                ScriptModel scriptModel = new ScriptModel();
                scriptModel.Name = xScript.Attribute("name").Value;
                scriptModel.Value = Business.FileBusiness.CreateInstance().Base2String(xScript.Attribute("value").Value);
                if (xScript.Attribute("parent") == null)
                {
                    scriptModel.Parent = "";
                }
                else
                {
                    scriptModel.Parent = xScript.Attribute("parent").Value;
                }
                if (xScript.Attribute("intersection") != null && !xScript.Attribute("intersection").Value.ToString().Trim().Equals(String.Empty))
                {
                    scriptModel.Intersection = xScript.Attribute("intersection").Value.Trim().Split(' ').ToList();
                }
                else
                {
                    scriptModel.Intersection = new List<String>();
                }
                if (xScript.Attribute("complement") != null && !xScript.Attribute("complement").Value.Equals(String.Empty))
                {
                    scriptModel.Complement = xScript.Attribute("complement").Value.Trim().Split(' ').ToList();
                }
                else
                {
                    scriptModel.Complement = new List<String>();
                }
                String visible = xScript.Attribute("visible").Value;
                if (visible.Equals("true"))
                {
                    scriptModel.Visible = true;
                }
                else
                {
                    scriptModel.Visible = false;
                }
                scriptModel.Contain = xScript.Attribute("contain").Value.Split(' ').ToList();
                //command = fileBusiness.Base2String(xScript.Attribute("value").Value);

                foreach (var xEdit in xScript.Elements()) {
                    if (xEdit.Name.ToString().Equals("VerticalFlipping"))
                    {
                        scriptModel.OperationModels.Add(new VerticalFlippingOperationModel());
                    }
                    else if (xEdit.Name.ToString().Equals("HorizontalFlipping"))
                    {
                        scriptModel.OperationModels.Add(new HorizontalFlippingOperationModel());
                    }
                    else if (xEdit.Name.ToString().Equals("LowerLeftSlashFlipping"))
                    {
                        scriptModel.OperationModels.Add(new LowerLeftSlashFlippingOperationModel());
                    }
                    else if (xEdit.Name.ToString().Equals("LowerRightSlashFlipping"))
                    {
                        scriptModel.OperationModels.Add(new LowerRightSlashFlippingOperationModel());
                    }
                    else if (xEdit.Name.ToString().Equals("Clockwise"))
                    {
                        scriptModel.OperationModels.Add(new ClockwiseOperationModel());
                    }
                    else if (xEdit.Name.ToString().Equals("AntiClockwise"))
                    {
                        scriptModel.OperationModels.Add(new AntiClockwiseOperationModel());
                    }
                    else if (xEdit.Name.ToString().Equals("RemoveBorder"))
                    {
                        scriptModel.OperationModels.Add(new RemoveBorderOperationModel());
                    }
                    else if (xEdit.Name.ToString().Equals("Reversal"))
                    {
                        scriptModel.OperationModels.Add(new ReversalOperationModel());
                    }
                    else if (xEdit.Name.ToString().Equals("ChangeTime"))
                    {
                        ChangeTimeOperationModel changeTimeOperationModel = new ChangeTimeOperationModel();
                        if (xEdit.Attribute("operator") != null && !xEdit.Attribute("operator").Value.ToString().Equals(String.Empty))
                        {
                            String operation = xEdit.Attribute("operator").Value;
                            if (operation.Equals("multiplication"))
                            {
                                changeTimeOperationModel.MyOperator = ChangeTimeOperationModel.Operation.MULTIPLICATION;
                            }
                            else if (operation.Equals("division"))
                            {
                                changeTimeOperationModel.MyOperator = ChangeTimeOperationModel.Operation.DIVISION;
                            }
                        }
                        if (xEdit.Attribute("multiple") != null && !xEdit.Attribute("multiple").Value.ToString().Equals(String.Empty))
                        {
                            String multiple = xEdit.Attribute("multiple").Value;
                            if (Double.TryParse(multiple, out double dMultiple)){
                                changeTimeOperationModel.Multiple = dMultiple;
                            }
                        }
                        scriptModel.OperationModels.Add(changeTimeOperationModel);
                    }
                    else if (xEdit.Name.ToString().Equals("FillColor") || xEdit.Name.ToString().Equals("SetAllTime") || xEdit.Name.ToString().Equals("MatchTotalTimeLattice"))
                    {
                        OneNumberOperationModel oneNumberOperationModel = new OneNumberOperationModel();
                        oneNumberOperationModel.Identifier = xEdit.Name.ToString();
                        if (xEdit.Attribute("number") != null && !xEdit.Attribute("number").Value.ToString().Equals(String.Empty))
                        {
                            String multiple = xEdit.Attribute("number").Value;
                            if (int.TryParse(multiple, out int iNumber))
                            {
                                oneNumberOperationModel.Number = iNumber;
                            }
                        }
                        oneNumberOperationModel.HintKeyword = xEdit.Attribute("hintKeyword").Value;
                        scriptModel.OperationModels.Add(oneNumberOperationModel);
                    }
                    else if (xEdit.Name.ToString().Equals("Fold"))
                    {
                        FoldOperationModel foldOperationModel = new FoldOperationModel();
                        if (xEdit.Attribute("orientation") != null && !xEdit.Attribute("orientation").Value.ToString().Equals(String.Empty))
                        {
                            String operation = xEdit.Attribute("orientation").Value;
                            if (operation.Equals("vertical"))
                            {
                                foldOperationModel.MyOrientation = FoldOperationModel.Orientation.VERTICAL;
                            }
                            else if (operation.Equals("horizontal"))
                            {
                                foldOperationModel.MyOrientation = FoldOperationModel.Orientation.HORIZONTAL;
                            }
                        }
                        if (xEdit.Attribute("startPosition") != null && !xEdit.Attribute("startPosition").Value.ToString().Equals(String.Empty))
                        {
                            String startPosition = xEdit.Attribute("startPosition").Value;
                            if (int.TryParse(startPosition, out int iStartPosition))
                            {
                                foldOperationModel.StartPosition = iStartPosition;
                            }
                        }
                        if (xEdit.Attribute("span") != null && !xEdit.Attribute("span").Value.ToString().Equals(String.Empty))
                        {
                            String span = xEdit.Attribute("span").Value;
                            if (int.TryParse(span, out int iSpan))
                            {
                                foldOperationModel.Span = iSpan;
                            }
                        }
                        scriptModel.OperationModels.Add(foldOperationModel);
                    }
                    else if (xEdit.Name.ToString().Equals("ChangeColor"))
                    {
                        ChangeColorOperationModel changeColorOperationModel = new ChangeColorOperationModel();
                        if (xEdit.Attribute("colors") != null && !xEdit.Attribute("colors").Value.ToString().Equals(String.Empty))
                        {
                            String colors = xEdit.Attribute("colors").Value;
                            String[] strsColor = colors.Split(' ');
                            foreach (var item in strsColor) {
                                if (int.TryParse(item, out int color)) {
                                    changeColorOperationModel.Colors.Add(color);
                                }
                            }
                        }
                        scriptModel.OperationModels.Add(changeColorOperationModel);
                    }
                  
                }
                scriptModelDictionary.Add(scriptModel.Name, scriptModel);
            }
            return scriptModelDictionary;
        }
        public static Dictionary<string, List<Light>> Test(Dictionary<String, ScriptModel> scriptModelDictionary)
        {
            CSharpCodeProvider objCSharpCodePrivoder = new CSharpCodeProvider();
            CompilerParameters objCompilerParameters = new CompilerParameters();

            //添加需要引用的dll
            objCompilerParameters.ReferencedAssemblies.Add("System.dll");
            objCompilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            objCompilerParameters.ReferencedAssemblies.Add("Operation.dll");
            //是否生成可执行文件
            objCompilerParameters.GenerateExecutable = false;

            //是否生成在内存中
            objCompilerParameters.GenerateInMemory = true;
            //编译代码
            CompilerResults cr = objCSharpCodePrivoder.CompileAssemblyFromSource(objCompilerParameters, Code.GetCode(scriptModelDictionary));
            if (cr.Errors.HasErrors)
            {
                var msg = string.Join(Environment.NewLine, cr.Errors.Cast<CompilerError>().Select(err => err.ErrorText));
                MessageBox.Show(msg, "编译错误");
            }
            else
            {
                Assembly objAssembly = cr.CompiledAssembly;
                object objHelloWorld = objAssembly.CreateInstance("Test");
                MethodInfo objMI = objHelloWorld.GetType().GetMethod("Hello");
                Dictionary<string,List<Operation.Light>> lights = (Dictionary<string, List<Operation.Light>>)objMI.Invoke(objHelloWorld, new Object[] { });
                Dictionary<string, List<Light>> mLights = new Dictionary<string, List<Light>>();
                foreach (var item in lights) {
                    List<Light> _lights = new List<Light>();
                    for (int i = 0; i < item.Value.Count; i++)
                    {
                        _lights.Add(new Light(item.Value[i].Time, item.Value[i].Action, item.Value[i].Position, item.Value[i].Color));
                    }
                    mLights.Add(item.Key,_lights);
                }
                
                return mLights;
            }
            return null;
        }
        public static List<Light> Test(Dictionary<String, ScriptModel> scriptModelDictionary, String stepName)
        {
            CSharpCodeProvider objCSharpCodePrivoder = new CSharpCodeProvider();
            CompilerParameters objCompilerParameters = new CompilerParameters();

            //添加需要引用的dll
            objCompilerParameters.ReferencedAssemblies.Add("System.dll");
            objCompilerParameters.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            objCompilerParameters.ReferencedAssemblies.Add("Operation.dll");
            //是否生成可执行文件
            objCompilerParameters.GenerateExecutable = false;

            //是否生成在内存中
            objCompilerParameters.GenerateInMemory = true;
            //编译代码
            CompilerResults cr = objCSharpCodePrivoder.CompileAssemblyFromSource(objCompilerParameters, Code.GetCode(scriptModelDictionary, stepName));
            if (cr.Errors.HasErrors)
            {
                var msg = string.Join(Environment.NewLine, cr.Errors.Cast<CompilerError>().Select(err => err.ErrorText));
                MessageBox.Show(msg, "编译错误");
            }
            else
            {
                Assembly objAssembly = cr.CompiledAssembly;
                object objHelloWorld = objAssembly.CreateInstance("Test");
                MethodInfo objMI = objHelloWorld.GetType().GetMethod("Hello");
                List<Operation.Light> lights = (List<Operation.Light>)objMI.Invoke(objHelloWorld, new Object[] { });
                List<Light> mLights = new List<Light>();
                for (int i = 0; i < lights.Count; i++)
                {
                    mLights.Add(new Light(lights[i].Time, lights[i].Action, lights[i].Position, lights[i].Color));
                }
                return mLights;
            }
            return null;
        }
    }
}
