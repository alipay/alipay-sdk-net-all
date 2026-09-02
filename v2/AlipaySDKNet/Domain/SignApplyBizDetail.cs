using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignApplyBizDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SignApplyBizDetail : AopObject
    {
        /// <summary>
        /// 回跳地址
        /// </summary>
        [XmlElement("back_addr")]
        public string BackAddr { get; set; }

        /// <summary>
        /// 用户模式
        /// </summary>
        [XmlElement("custtype")]
        public string Custtype { get; set; }

        /// <summary>
        /// 冻结金额，单位：CNY
        /// </summary>
        [XmlElement("freeze_amount")]
        public string FreezeAmount { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("id_number")]
        public string IdNumber { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 套餐ID
        /// </summary>
        [XmlElement("pack_id")]
        public string PackId { get; set; }

        /// <summary>
        /// 套餐名称
        /// </summary>
        [XmlElement("pack_name")]
        public string PackName { get; set; }

        /// <summary>
        /// 套餐价格，单位：CNY
        /// </summary>
        [XmlElement("pack_price")]
        public string PackPrice { get; set; }

        /// <summary>
        /// 商品金额，单位：CNY
        /// </summary>
        [XmlElement("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 用户所在省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 分期期数
        /// </summary>
        [XmlElement("repayments")]
        public long Repayments { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("social_credit_code")]
        public string SocialCreditCode { get; set; }

        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("store_address")]
        public string StoreAddress { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
