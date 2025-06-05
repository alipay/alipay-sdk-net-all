using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeRecommendPreconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeRecommendPreconsultModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("biz_id_list")]
        [XmlArrayItem("string")]
        public List<string> BizIdList { get; set; }

        /// <summary>
        /// 场景码，用于标记不同的场景。
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// AMPE设备ID，用于标记唯一的一台设备。
        /// </summary>
        [XmlElement("device_id")]
        public string DeviceId { get; set; }

        /// <summary>
        /// AMPE产品ID，在开放平台注册后可获取。
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 请求流水号。
        /// </summary>
        [XmlElement("req_no")]
        public string ReqNo { get; set; }
    }
}
