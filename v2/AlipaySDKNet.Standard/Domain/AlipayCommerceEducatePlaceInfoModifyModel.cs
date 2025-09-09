using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducatePlaceInfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducatePlaceInfoModifyModel : AopObject
    {
        /// <summary>
        /// 关联学工号列表，比如某寝室居住4名学生的学工号列表
        /// </summary>
        [XmlArray("employee_no_list")]
        [XmlArrayItem("string")]
        public List<string> EmployeeNoList { get; set; }

        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 外部唯一编号，不可重复
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 上级位置ID
        /// </summary>
        [XmlElement("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// 上级位置外部唯一编号
        /// </summary>
        [XmlElement("parent_out_biz_no")]
        public string ParentOutBizNo { get; set; }

        /// <summary>
        /// 位置ID
        /// </summary>
        [XmlElement("place_id")]
        public string PlaceId { get; set; }

        /// <summary>
        /// 位置标签
        /// </summary>
        [XmlElement("place_label")]
        public string PlaceLabel { get; set; }

        /// <summary>
        /// 位置图片地址URL
        /// </summary>
        [XmlElement("place_logo")]
        public string PlaceLogo { get; set; }

        /// <summary>
        /// 位置名称
        /// </summary>
        [XmlElement("place_name")]
        public string PlaceName { get; set; }

        /// <summary>
        /// 位置点位信息
        /// </summary>
        [XmlElement("poi")]
        public EduPlacePointInfo Poi { get; set; }
    }
}
