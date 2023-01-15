using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MultiDataOpenResult Data Structure.
    /// </summary>
    [Serializable]
    public class MultiDataOpenResult : AopObject
    {
        /// <summary>
        /// 所有区间对应的用户平均数量
        /// </summary>
        [XmlElement("avg_num")]
        public string AvgNum { get; set; }

        /// <summary>
        /// 数据区间分布横轴
        /// </summary>
        [XmlElement("feature_key")]
        public string FeatureKey { get; set; }

        /// <summary>
        /// 主体id，如小程序appid
        /// </summary>
        [XmlElement("object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// 主体名称，如小程序名称
        /// </summary>
        [XmlElement("object_name")]
        public string ObjectName { get; set; }

        /// <summary>
        /// 主体类型
        /// </summary>
        [XmlElement("object_type")]
        public string ObjectType { get; set; }

        /// <summary>
        /// 区间对应的用户数量
        /// </summary>
        [XmlElement("user_cnt")]
        public string UserCnt { get; set; }

        /// <summary>
        /// 区间对应的用户比例
        /// </summary>
        [XmlElement("user_ratio")]
        public string UserRatio { get; set; }
    }
}
