using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpProductCodeQueryResponse.
    /// </summary>
    public class ZhimaCreditEpProductCodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务明细信息：  biz_no:业务借据号  biz_date：支用日期  biz_amount:支用金额  biz_user_id:业务消费者唯一标志
        /// </summary>
        [XmlArray("biz_info")]
        [XmlArrayItem("biz_res_data")]
        public List<BizResData> BizInfo { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_cnt")]
        public long TotalCnt { get; set; }
    }
}
