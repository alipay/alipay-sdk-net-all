using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherCodedepositResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherCodedepositResponse : AopResponse
    {
        /// <summary>
        /// 导入失败的券码数量
        /// </summary>
        [XmlElement("fail_count")]
        public long FailCount { get; set; }

        /// <summary>
        /// 上传失败券码详情列表，包括上传失败的券码及对应的错误码和错误原因
        /// </summary>
        [XmlArray("fail_voucher_code_detail_list")]
        [XmlArrayItem("fail_voucher_code_detail")]
        public List<FailVoucherCodeDetail> FailVoucherCodeDetailList { get; set; }

        /// <summary>
        /// 导入成功的券码数量
        /// </summary>
        [XmlElement("success_count")]
        public long SuccessCount { get; set; }

        /// <summary>
        /// 上传成功的券码列表
        /// </summary>
        [XmlArray("success_voucher_code_list")]
        [XmlArrayItem("string")]
        public List<string> SuccessVoucherCodeList { get; set; }
    }
}
