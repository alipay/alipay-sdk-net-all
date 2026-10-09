using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayVoyagerMarketingBatchconsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayVoyagerMarketingBatchconsultModel : AopObject
    {
        /// <summary>
        /// AGENT / GUI，为空默认 GUI
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 环境信息
        /// </summary>
        [XmlElement("env_info")]
        public VoyagerEnvInfo EnvInfo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("goods_info_list")]
        [XmlArrayItem("voyager_goods_info")]
        public List<VoyagerGoodsInfo> GoodsInfoList { get; set; }

        /// <summary>
        /// 行业标识
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 多语言
        /// </summary>
        [XmlElement("language")]
        public string Language { get; set; }

        /// <summary>
        /// 用户 openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户 2088 UID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
