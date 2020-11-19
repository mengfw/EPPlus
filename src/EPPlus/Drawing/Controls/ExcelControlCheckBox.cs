﻿/*************************************************************************************************
  Required Notice: Copyright (C) EPPlus Software AB. 
  This software is licensed under PolyForm Noncommercial License 1.0.0 
  and may only be used for noncommercial purposes 
  https://polyformproject.org/licenses/noncommercial/1.0.0/

  A commercial license to use this software can be purchased at https://epplussoftware.com
 *************************************************************************************************
  Date               Author                       Change
 *************************************************************************************************
  10/21/2020         EPPlus Software AB           Controls 
 *************************************************************************************************/
using OfficeOpenXml.Packaging;
using OfficeOpenXml.Utils.Extentions;
using System.Xml;

namespace OfficeOpenXml.Drawing.Controls
{
    public class ExcelControlCheckBox : ExcelControlWithText
    {
        internal ExcelControlCheckBox(ExcelDrawings drawings, XmlElement drawNode) : base(drawings, drawNode)
        {
        }

        internal ExcelControlCheckBox(ExcelDrawings drawings, XmlNode drawNode, ControlInternal control, ZipPackagePart part, XmlDocument controlPropertiesXml)
            : base(drawings, drawNode, control, part, controlPropertiesXml, null)
        {
        }

        public override eControlType ControlType => eControlType.CheckBox;
        /// <summary>
        /// Gets or sets if a check box or radio button is selected
        /// </summary>
        public eCheckState Checked 
        { 
            get
            {
                return _ctrlProp.GetXmlNodeString("@checked").ToEnum(eCheckState.Unchecked);
            }
            set
            {
                _ctrlProp.SetXmlNodeString("@checked", value.ToEnumString());
            }
        }

        ExcelVmlDrawingFill _fill = null;
        public ExcelVmlDrawingFill Fill
        {
            get
            {
                if(_fill==null)
                {
                    _fill=new ExcelDrawingFill(_drawings, NameSpaceManager, TopNode, "xdr:sp/xdr:spPr", SchemaNodeOrder);
                }
                return _fill;
            }
        }
        ExcelDrawingBorder _border = null;
        public ExcelDrawingBorder Border
        {
            get
            {
                if (_border == null)
                {
                    _border = new ExcelDrawingBorder(_drawings, NameSpaceManager, TopNode, "xdr:sp/xdr:spPr", SchemaNodeOrder);
                }
                return _border;
            }
        }
    }
}