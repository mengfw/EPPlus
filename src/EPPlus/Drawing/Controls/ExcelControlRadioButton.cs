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
using System.Xml;

namespace OfficeOpenXml.Drawing.Controls
{
    public class ExcelControlRadioButton : ExcelControl
    {
        internal ExcelControlRadioButton(ExcelDrawings drawings, XmlNode drawNode, ControlInternal control, ZipPackageRelationship rel, XmlDocument controlPropertiesXml)
            : base(drawings, drawNode, control, rel,  controlPropertiesXml, null)
        {
        }

        public override eControlType ControlType => eControlType.RadioButton;
        /// <summary>
        /// Gets or sets if a check box or radio button is selected
        /// </summary>
        public bool Checked
        {
            get
            {
                return _ctrlProp.GetXmlNodeBool("@checked");
            }
            set
            {
                _ctrlProp.SetXmlNodeBool("@checked", value);
            }
        }
        /// <summary>
        /// Gets or sets whether a radiobutton's text is locked.
        /// </summary>
        public bool LockedText
        {
            get
            {
                return _ctrlProp.GetXmlNodeBool("@lockedText");
            }
            set
            {
                _ctrlProp.SetXmlNodeBool("@lockedText", value);
            }
        }

        /// <summary>
        /// Gets or sets if the radio button is the first button in a set of radio buttons
        /// </summary>
        public bool FirstButton
        {
            get
            {
                return _ctrlProp.GetXmlNodeBool("@firstButton");
            }
            set
            {
                _ctrlProp.SetXmlNodeBool("@firstButton", value);
            }
        }        
    }
}