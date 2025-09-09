using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignBatchcreativestatusModifyResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignBatchcreativestatusModifyResponse : AopResponse
    {
        /// <summary>
        /// 操作失败创意id集合
        /// </summary>
        [XmlArray("fail_res_list")]
        [XmlArrayItem("operate_fail_res")]
        public List<OperateFailRes> FailResList { get; set; }

        /// <summary>
        /// 操作成功创意id集合
        /// </summary>
        [XmlArray("success_id_list")]
        [XmlArrayItem("number")]
        public List<long> SuccessIdList { get; set; }
    }
}
