﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maker.Business.Model.OperationModel
{
    [Serializable]
    public class CreateFromQuickOperationModel : CreateOperationModel
    {

        public int Time
        {
            get;
            set;
        }

        public List<int> PositionList
        {
            get;
            set;
        }

        public int Interval
        {
            get;
            set;
        }

        public int Continued
        {
            get;
            set;
        }

        public List<int> ColorList
        {
            get;
            set;
        }

        public int Type
        {
            get;
            set;
        }

        public int Action
        {
            get;
            set;
        }

        public CreateFromQuickOperationModel()
        {

        }

        public CreateFromQuickOperationModel(int time, List<int> rangeList, int interval, int continued, List<int> colorList, int type, int action)
        {
            Time = time;
            PositionList = rangeList;
            Interval = interval;
            Continued = continued;
            ColorList = colorList;
            Type = type;
            Action = action;
        }
    }
}
