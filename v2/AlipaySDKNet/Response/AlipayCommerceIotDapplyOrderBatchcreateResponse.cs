using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotDapplyOrderBatchcreateResponse.
    /// </summary>
    public class AlipayCommerceIotDapplyOrderBatchcreateResponse : AopResponse
    {
        /// <summary>
        /// 下单成功后返回批次订单号可以利用批订单号查询子单信息
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// Excel校验明细
        /// </summary>
        [XmlElement("excel_validate_detail_file")]
        public string ExcelValidateDetailFile { get; set; }
    }
}
