using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingActivityIotdeliveryBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingActivityIotdeliveryBatchqueryModel : AopObject
    {
        /// <summary>
        /// 服务商代商户创建投放必选。 bussinessType设置为ISV_FOR_MERCHANT。
        /// </summary>
        [XmlElement("belong_merchant_info")]
        public IotDeliveryAgencyMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 从1开始计算。如要查前20条，应该传page_no=1, page_size=20。 默认值为1
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 参数名：单页数据行数 应用场景：分页查询 如何获取：查询时用户自行指定 使用说明：单页查询行数不宜过大 默认值为10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 筛选投放计划的状态
        /// </summary>
        [XmlArray("status")]
        [XmlArrayItem("string")]
        public List<string> Status { get; set; }
    }
}
