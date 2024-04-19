using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandAssetinfoCheckSyncResponse.
    /// </summary>
    public class AntMerchantExpandAssetinfoCheckSyncResponse : AopResponse
    {
        /// <summary>
        /// 返回的批次号和请求的相同
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 供应商名下无此分配记录,错误信息
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 具体的错误信息
        /// </summary>
        [XmlArray("sub_check_infos")]
        [XmlArrayItem("asset_sub_feedback_info")]
        public List<AssetSubFeedbackInfo> SubCheckInfos { get; set; }
    }
}
