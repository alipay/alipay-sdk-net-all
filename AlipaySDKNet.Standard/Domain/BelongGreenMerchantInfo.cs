using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BelongGreenMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BelongGreenMerchantInfo : AopObject
    {
        /// <summary>
        /// 合作业务类型. 枚举值如下：  ISV_FOR_MERCHANT 服务商代运营模式  （SOP请参考 https://opendocs.alipay.com/mini/01hm6i#%E4%BB%A3%E8%BF%90%E8%90%A5%E6%8E%88%E6%9D%83）
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 商户PID
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }
    }
}
