using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenSearchSubservicekeywordApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenSearchSubservicekeywordApplyModel : AopObject
    {
        /// <summary>
        /// 关键词配置id，由支付宝生成，关键词申请通过后会通知接口返回，也可以申请单状态获取
        /// </summary>
        [XmlElement("config_id")]
        public string ConfigId { get; set; }

        /// <summary>
        /// 服务关键词列表，每批最多传入30个，关键词长度小于12个汉字。 超过数量限制会申请失败，剩余关键词可通过 <a href="https://opendocs.alipay.com/mini/062ndt?pathHash=e3e78b68&ref=api&scene=common">alipay.open.search.appkeywordquota.query</a>查询
        /// </summary>
        [XmlArray("key_words")]
        [XmlArrayItem("string")]
        public List<string> KeyWords { get; set; }

        /// <summary>
        /// 子服务code，提报服务关键词，alipay.open.app.service.list.query(服务批量查询)这个接口可以获取
        /// </summary>
        [XmlElement("sub_service_code")]
        public string SubServiceCode { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("target_appid")]
        public string TargetAppid { get; set; }
    }
}
