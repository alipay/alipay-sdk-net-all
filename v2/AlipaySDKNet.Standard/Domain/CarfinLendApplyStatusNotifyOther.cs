using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinLendApplyStatusNotifyOther Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinLendApplyStatusNotifyOther : AopObject
    {
        /// <summary>
        /// 是否安装GPS
        /// </summary>
        [XmlElement("needs_gps_installation")]
        public bool NeedsGpsInstallation { get; set; }
    }
}
