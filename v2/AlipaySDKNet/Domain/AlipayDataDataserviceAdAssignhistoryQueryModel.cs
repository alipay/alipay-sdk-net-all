using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdAssignhistoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdAssignhistoryQueryModel : AopObject
    {
        /// <summary>
        /// 分配动作： "ASSIGN"-转入 "CUT"-转出
        /// </summary>
        [XmlElement("apply_type")]
        public string ApplyType { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("current")]
        public long Current { get; set; }

        /// <summary>
        /// 数据查询结束时间，时间格式：yyyy-MM-dd
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 每页条数，最大100，明细按日期倒序
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 钱包类型： 通用钱包-INTELLIGENT 外投钱包-XAB_BP
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 数据查询开始时间，时间格式：yyyy-MM-dd，开始时间不能大于当前日期，不能大于结束时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
