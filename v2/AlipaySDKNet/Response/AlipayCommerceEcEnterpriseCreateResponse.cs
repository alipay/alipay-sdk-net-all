using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseCreateResponse.
    /// </summary>
    public class AlipayCommerceEcEnterpriseCreateResponse : AopResponse
    {
        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 封闭场景（如班车）的人脸库id，如果入参create_iot_group传false，则不会创建企业人脸库，该字段为空。
        /// </summary>
        [XmlElement("iot_group_id")]
        public string IotGroupId { get; set; }

        /// <summary>
        /// 开放场景（如团餐）的人脸库id，如果入参create_iot_group传false，则不会创建企业人脸库，该字段为空。
        /// </summary>
        [XmlElement("iot_logic_group_id")]
        public string IotLogicGroupId { get; set; }

        /// <summary>
        /// 资金代付签约链接
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
