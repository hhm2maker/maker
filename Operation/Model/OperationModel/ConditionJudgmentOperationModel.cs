﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maker.Business.Model.OperationModel
{
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

        public String IfTime
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
        }

        public List<int> IfColor
        {
            get;
            set;
        }

        public String ThenTime
        {
            get;
            set;
        }

        public String ThenPosition
        {
            get;
            set;
        }

        public String ThenColor
        {
            get;
            set;
        }


        public ConditionJudgmentOperationModel()
        {

        }

        public ConditionJudgmentOperationModel(Operation myOperator, string ifTime, int ifAction, List<int> ifPosition, List<int> ifColor, string thenTime, string thenPosition, string thenColor)
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