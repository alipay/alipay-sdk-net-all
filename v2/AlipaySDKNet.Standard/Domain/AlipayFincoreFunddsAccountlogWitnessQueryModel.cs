using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreFunddsAccountlogWitnessQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreFunddsAccountlogWitnessQueryModel : AopObject
    {
        /// <summary>
        /// 子户account_no,查询监管户流水不需要填写
        /// </summary>
        [XmlElement("account_no")]
        public string AccountNo { get; set; }

        /// <summary>
        /// 账户类型,本次支持监管户和托管子户 SUPERVISED_ACC-监管户 ENTRUST_SUB_ACC-托管子户
        /// </summary>
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 此字段专门用于：存管户在支付宝收单类型入金场景下，按照支付宝交易单号查询该入金账务流水。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 结束时间，yyyy-mm-dd hh:mm:ss形式
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 查询页码，默认1。注：必须大于0
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小，默认20。 注：0< pageSize <= 20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 签约产品码,唯一,区分资金存管服务产品类型
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 开始时间，yyyy-mm-dd hh:mm:ss形式
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 用户id|二级商户smid，查询子户时必填，查询监管户不填
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
