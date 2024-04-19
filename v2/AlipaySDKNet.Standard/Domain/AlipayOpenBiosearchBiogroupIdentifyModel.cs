using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenBiosearchBiogroupIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenBiosearchBiogroupIdentifyModel : AopObject
    {
        /// <summary>
        /// 随机数，用于排查定位每笔请求
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 比对难度值，值越大要求难度越大，也就是在生物库中搜索的拦截分数越高，0表示不做分数拦截，默认为3
        /// </summary>
        [XmlElement("compare_level")]
        public string CompareLevel { get; set; }

        /// <summary>
        /// 生物数据，要求为jpg/jpeg格式，需要进行apache base64转化，数据需要小于1M，如果为人像时需要正立、清晰
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 生物库ID，由字母、数字、下划线组成，无中文和特殊字符
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 应用在哪个业务场景，默认为通用场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 最大返回结果数，默认最多返回1个
        /// </summary>
        [XmlElement("top_n")]
        public long TopN { get; set; }
    }
}
