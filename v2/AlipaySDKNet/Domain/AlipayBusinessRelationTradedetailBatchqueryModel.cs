using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBusinessRelationTradedetailBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessRelationTradedetailBatchqueryModel : AopObject
    {
        /// <summary>
        /// 商业关系id，如：商圈mallid
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 商业关系组织子类型 定向参数 需找对应BD申请
        /// </summary>
        [XmlElement("group_sub_type")]
        public string GroupSubType { get; set; }

        /// <summary>
        /// 商业关系组织类型 定向参数 需找对应BD申请
        /// </summary>
        [XmlElement("group_type")]
        public string GroupType { get; set; }

        /// <summary>
        /// 查询页数
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页查询大小，建议填10，限制最大为20
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        [XmlElement("real_shop_no")]
        public string RealShopNo { get; set; }

        /// <summary>
        /// 查询日期，格式：yyyyMMdd
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
