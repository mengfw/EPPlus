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
using System;
using System.Xml;

namespace OfficeOpenXml.Drawing.Controls
{
    public class ExcelControlSpin : ExcelControl
    {
        internal ExcelControlSpin(ExcelDrawings drawings, XmlNode drawNode, ControlInternal control, ZipPackageRelationship rel, XmlDocument controlPropertiesXml)
            : base(drawings, drawNode, control, rel,  controlPropertiesXml, null)
        {
        }

        public override eControlType ControlType => eControlType.Spin;
        /// <summary>
        /// How much the scrollbar is incremented for each click
        /// </summary>
        public int Increment
        {
            get
            {
                return _ctrlProp.GetXmlNodeInt("@inc", 1);
            }
            set
            {
                if (value < 0 || value > 30000)
                {
                    throw (new ArgumentOutOfRangeException("Increment must be between 0 and 3000"));
                }
                _ctrlProp.SetXmlNodeInt("@inc", value);
            }
        }
        /// <summary>
        /// The value when a scrollbar is at it's minimum
        /// </summary>
        public int MinValue
        {
            get
            {
                return _ctrlProp.GetXmlNodeInt("@min", 1);
            }
            set
            {
                if (value < 0 || value > 30000)
                {
                    throw (new ArgumentOutOfRangeException("MinValue must be between 0 and 3000"));
                }
                _ctrlProp.SetXmlNodeInt("@min", value);
            }
        }
        /// <summary>
        /// The value when a scrollbar is at it's maximum
        /// </summary>
        public int MaxValue
        {
            get
            {
                return _ctrlProp.GetXmlNodeInt("@max", 1);
            }
            set
            {
                if (value < 0 || value > 30000)
                {
                    throw (new ArgumentOutOfRangeException("MaxValue must be between 0 and 3000"));
                }
                _ctrlProp.SetXmlNodeInt("@max", value);
            }
        }
        //TODO: Implement?
        //public bool JustLastX
        //{

        //}
        /// <summary>
        /// The number of items to move the scroll bar on a page click. Null is default
        /// </summary>
        public int? Page
        {
            get
            {
                return _ctrlProp.GetXmlNodeIntNull("@page");
            }
            set
            {
                if (value.HasValue && (value < 0 || value > 3000))
                {
                    throw (new ArgumentOutOfRangeException("Page must be between 0 and 3000"));
                }
                _ctrlProp.SetXmlNodeInt("@page", value);
            }
        }
    }
}