using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsPointWorkCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLogisticsPointWorkCreateModel : AopObject
    {
        /// <summary>
        /// 生成连接的有效期，允许为空。默认有效期1D。
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 商户侧作业编号，64位，用来做幂等控制
        /// </summary>
        [XmlElement("work_biz_no")]
        public string WorkBizNo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("work_place_list")]
        [XmlArrayItem("work_place")]
        public List<WorkPlace> WorkPlaceList { get; set; }

        /// <summary>
        /// 物流行业作业平台展示的点位，和铺设点联合使用。见铺设点示例
        /// </summary>
        [XmlElement("work_point_id")]
        public string WorkPointId { get; set; }
    }
}
