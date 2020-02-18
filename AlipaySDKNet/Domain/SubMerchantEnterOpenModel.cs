using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SubMerchantEnterOpenModel Data Structure.
    /// </summary>
    [Serializable]
    public class SubMerchantEnterOpenModel : AopObject
    {
        /// <summary>
        /// 扩展字段，为json字符串格式；入驻缴费后开票的产品如果需要传入自定义开票链接，由此字段传入。
        /// </summary>
        [XmlElement("extend_fields")]
        public string ExtendFields { get; set; }

        /// <summary>
        /// 商户行业，枚举值如下：subway：地铁，etc：ETC，online_car_hailing：网约车，catering：餐饮，hotel：酒店，convenience_store：便利店，oil：加油，insurance：保险，service_provider：运营商，life_payment：生活缴费，political：政务，other：其他
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 开票商户pid，入驻支付即开票场景的时候，该字段必传
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 商户门店税号。
        /// </summary>
        [XmlElement("register_no")]
        public string RegisterNo { get; set; }

        /// <summary>
        /// 商户门店全称。
        /// </summary>
        [XmlElement("sub_m_name")]
        public string SubMName { get; set; }

        /// <summary>
        /// 商户门店简称，只能由大写字母、下划线、数字组成，且必须以大写字母开头。
        /// </summary>
        [XmlElement("sub_m_short_name")]
        public string SubMShortName { get; set; }
    }
}
