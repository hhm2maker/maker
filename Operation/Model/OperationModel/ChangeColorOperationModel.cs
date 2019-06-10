﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maker.Business.Model.OperationModel
{
    [Serializable]
    public class ChangeColorOperationModel : ColorOperationModel
    {
        public ChangeColorOperationModel():base()
        {
            HintString = "CustomFormattedColorColon";
        }

        public ChangeColorOperationModel(List<int> colors) : base(colors)
        {
            HintString = "CustomFormattedColorColon";
        }
    }
}
