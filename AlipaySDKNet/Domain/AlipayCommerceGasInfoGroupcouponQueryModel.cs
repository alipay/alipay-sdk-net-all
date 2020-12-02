using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceGasInfoGroupcouponQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceGasInfoGroupcouponQueryModel : AopObject
    {
        /// <summary>
        /// 劵创建结束时间:格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_end_time")]
        public string CreateEndTime { get; set; }

        /// <summary>
        /// 劵创建开始时间:格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("create_start_time")]
        public string CreateStartTime { get; set; }

        /// <summary>
        /// 当前页码,不填写默认第一页
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页显示数,不填写默认10条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// shop_id和partner_id不能同时为空
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// ENABLED:可用,多个状态逗号分开,DISABLED:不可用, 多个逗号分隔，例如:ENABLED,DISABLED
        /// </summary>
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }
    }
}
