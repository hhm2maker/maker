﻿using Maker.Business.Model.OperationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operation
{
    [Serializable]
    public class ConditionJudgmentOperationModel : BaseOperationModel
    {
        public enum Operation
        {
            REPLACE = 40,
            REMOVE = 41,
        }

        public Operation MyOperator {
            get;
            set;
        }

        public int IfTime
        {
            get;
            set;
        }

        public int IfAction
        {
            get;
            set;
        }

        public List<int> IfPosition
        {
            get;
            set;
        } = new List<int>();

        public List<int> IfColor
        {
            get;
            set;
        } = new List<int>();

        public String ThenTime
        {
            get;
            set;
        } = "";

        public String ThenPosition
        {
            get;
            set;
        } = "";

        public String ThenColor
        {
            get;
            set;
        } = "";


        public ConditionJudgmentOperationModel()
        {

        }

        public ConditionJudgmentOperationModel(Operation myOperator, int ifTime, int ifAction, List<int> ifPosition, List<int> ifColor, string thenTime, string thenPosition, string thenColor)
        {
            MyOperator = myOperator;
            IfTime = ifTime;
            IfAction = ifAction;
            IfPosition = ifPosition;
            IfColor = ifColor;
            ThenTime = thenTime;
            ThenPosition = thenPosition;
            ThenColor = thenColor;
        }
    }
}
