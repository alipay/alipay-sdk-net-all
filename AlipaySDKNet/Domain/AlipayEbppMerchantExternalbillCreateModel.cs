using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppMerchantExternalbillCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppMerchantExternalbillCreateModel : AopObject
    {
        /// <summary>
        /// 账期金额,单位元
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 账期描述
        /// </summary>
        [XmlElement("bill_date_desc")]
        public string BillDateDesc { get; set; }

        /// <summary>
        /// 账期结束时间
        /// </summary>
        [XmlElement("bill_date_end")]
        public string BillDateEnd { get; set; }

        /// <summary>
        /// 账期起始时间
        /// </summary>
        [XmlElement("bill_date_start")]
        public string BillDateStart { get; set; }

        /// <summary>
        /// 主业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 账单过期时间, 可为空, 默认2099年
        /// </summary>
        [XmlElement("expiry_date")]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// PROPERTY_MNG("PROPERTY_MNG", "物业费"), PROPERTY_WATER("PROPERTY_WATER", "代收水费"), PROPERTY_ELECTRIC("PROPERTY_ELECTRIC", "代收电费"), PROPERTY_SHARE("PROPERTY_SHARE", "公共维护金"), PROPERTY_PARK_MNG("PROPERTY_PARK_MNG", "车位管理费"), PROPERTY_PARK_LEASE("PROPERTY_PARK_LEASE", "车位租赁费"), PROPERTY_ROOM_LEASE("PROPERTY_ROOM_LEASE", "房屋租赁费"), PROPERTY_TEMP_PARK("PROPERTY_TEMP_PARK", "临时停车费");
        /// </summary>
        [XmlElement("fee_type")]
        public string FeeType { get; set; }

        /// <summary>
        /// 滞纳金, 单位元
        /// </summary>
        [XmlElement("fine_amount")]
        public string FineAmount { get; set; }

        /// <summary>
        /// 滞纳金产生时间, 空代表不会出现滞纳金
        /// </summary>
        [XmlElement("fine_date")]
        public string FineDate { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 缴费商户短码
        /// </summary>
        [XmlElement("merchant_code")]
        public string MerchantCode { get; set; }

        /// <summary>
        /// 缴费实体ID
        /// </summary>
        [XmlElement("object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 账单生效时间, 空默认当前时间
        /// </summary>
        [XmlElement("release_date")]
        public string ReleaseDate { get; set; }

        /// <summary>
        /// 该账单是否用户可选 ，1 可选 0不可选，默认不可选
        /// </summary>
        [XmlElement("select_optional")]
        public string SelectOptional { get; set; }

        /// <summary>
        /// 账单排列顺序
        /// </summary>
        [XmlElement("sequence")]
        public long Sequence { get; set; }

        /// <summary>
        /// 服务费, 单位元
        /// </summary>
        [XmlElement("service_amount")]
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 子业务类型
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 账单总金额,单位 元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
