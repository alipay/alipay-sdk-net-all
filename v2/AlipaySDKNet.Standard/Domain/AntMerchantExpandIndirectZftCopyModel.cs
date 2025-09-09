using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectZftCopyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandIndirectZftCopyModel : AopObject
    {
        /// <summary>
        /// 直付通二级商户迁移后所属服务商PID
        /// </summary>
        [XmlElement("pid_new")]
        public string PidNew { get; set; }

        /// <summary>
        /// 待迁移的直付通二级商户smid
        /// </summary>
        [XmlElement("smid_old")]
        public string SmidOld { get; set; }
    }
}
