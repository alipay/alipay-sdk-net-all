using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HbMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class HbMerchantInfo : AopObject
    {
        /// <summary>
        /// 描述收单模式，目前取值有 直联/间联/境外
        /// </summary>
        [XmlElement("acquire_mode")]
        public string AcquireMode { get; set; }

        /// <summary>
        /// 用于区分店铺的粒度，取值 有 PID/SMID/PID_MID/PID_MID_SID/PID_ORGID 等
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 原始ID拼接串，根据粒度的不同，最多4个ID的拼接
        /// </summary>
        [XmlElement("origin_config_info")]
        public string OriginConfigInfo { get; set; }
    }
}
