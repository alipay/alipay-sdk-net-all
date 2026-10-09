using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserSportsrecordQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserSportsrecordQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁开放ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务编码
        /// </summary>
        [XmlElement("out_biz_code")]
        public string OutBizCode { get; set; }

        /// <summary>
        /// 页码，从1开始
        /// </summary>
        [XmlElement("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每一页返回的，数据大小；最大不超过50
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 流水日期
        /// </summary>
        [XmlElement("record_date")]
        public string RecordDate { get; set; }

        /// <summary>
        /// 需要查询的运动类型 walk 步行 ride 骑行 run 跑步
        /// </summary>
        [XmlArray("sport_types")]
        [XmlArrayItem("string")]
        public List<string> SportTypes { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
