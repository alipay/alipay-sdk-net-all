using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExpenseInvoiceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExpenseInvoiceInfo : AopObject
    {
        /// <summary>
        /// 员工ID
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 员工ID
        /// </summary>
        [XmlElement("employee_open_id")]
        public string EmployeeOpenId { get; set; }

        /// <summary>
        /// 电子发票结构化信息
        /// </summary>
        [XmlElement("invoice_output_info")]
        public InvoiceOutputInfo InvoiceOutputInfo { get; set; }

        /// <summary>
        /// 增值税发票、定额发票、卷式发票、过路费
        /// </summary>
        [XmlElement("ocr_normal_scan_info")]
        public OcrNormalScanInfo OcrNormalScanInfo { get; set; }

        /// <summary>
        /// 飞机票结构化信息
        /// </summary>
        [XmlElement("ocr_plane_scan_info")]
        public OcrPlaneScanInfo OcrPlaneScanInfo { get; set; }

        /// <summary>
        /// 出租车票结构化信息
        /// </summary>
        [XmlElement("ocr_taxi_scan_info")]
        public OcrTaxiScanInfo OcrTaxiScanInfo { get; set; }

        /// <summary>
        /// 火车票结构化信息
        /// </summary>
        [XmlElement("ocr_train_scan_info")]
        public OcrTrainScanInfo OcrTrainScanInfo { get; set; }

        /// <summary>
        /// 凭证文件信息
        /// </summary>
        [XmlElement("voucher_file_info")]
        public VoucherFileInfo VoucherFileInfo { get; set; }

        /// <summary>
        /// 凭证ID
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
