using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechMorseMarketingEquityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechMorseMarketingEquityQueryModel : AopObject
    {
        /// <summary>
        /// 外部业务号，业务的标识由商户生成，可以设置成订单号,要保证幂等和唯一性
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商务项目ID，由摩斯配置并分配给调用方
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }

        /// <summary>
        /// 摩斯营销发奖类型
        /// </summary>
        [XmlElement("send_type")]
        public string SendType { get; set; }
    }
}
