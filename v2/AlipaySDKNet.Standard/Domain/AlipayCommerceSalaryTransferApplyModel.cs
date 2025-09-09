using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSalaryTransferApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSalaryTransferApplyModel : AopObject
    {
        /// <summary>
        /// 转账关联的业务单据列表
        /// </summary>
        [XmlArray("biz_salary_order")]
        [XmlArrayItem("biz_salary_order")]
        public List<BizSalaryOrder> BizSalaryOrder { get; set; }

        /// <summary>
        /// 转账申请场景码
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 转账申请的外部单号，参与幂等的关键参数。多次请求相同场景下的相同的外部单号会命中幂等，返回上次成功的结果。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 转账申请产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 转账详情
        /// </summary>
        [XmlElement("transfer_info")]
        public SalaryTransferInfo TransferInfo { get; set; }
    }
}
