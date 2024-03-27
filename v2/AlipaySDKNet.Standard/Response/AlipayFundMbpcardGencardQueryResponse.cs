using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundMbpcardGencardQueryResponse.
    /// </summary>
    public class AlipayFundMbpcardGencardQueryResponse : AopResponse
    {
        /// <summary>
        /// 预付卡卡密信息集合
        /// </summary>
        [XmlArray("asset_cert_info_list")]
        [XmlArrayItem("asset_cert_info")]
        public List<AssetCertInfo> AssetCertInfoList { get; set; }

        /// <summary>
        /// 卡密信息查询备注
        /// </summary>
        [XmlElement("asset_cert_remark")]
        public string AssetCertRemark { get; set; }

        /// <summary>
        /// 制卡结果文件路径；支持多个； 已生成和已激活时返回；
        /// </summary>
        [XmlArray("file_path_list")]
        [XmlArrayItem("string")]
        public List<string> FilePathList { get; set; }

        /// <summary>
        /// 制卡单号
        /// </summary>
        [XmlElement("gen_card_no")]
        public string GenCardNo { get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 返回描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 状态： ACCEPTED-已受理 GENERATED-已生成 ENABLED-已激活 CLOSED-已关单
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
