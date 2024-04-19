using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechMorseMarketingShopTaskUploadResponse.
    /// </summary>
    public class AnttechMorseMarketingShopTaskUploadResponse : AopResponse
    {
        /// <summary>
        /// 存在空情况未成功创建任务，否则返回任务id，用于查询门店数据
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
