using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringKmsBakingSyncResponse.
    /// </summary>
    public class KoubeiCateringKmsBakingSyncResponse : AopResponse
    {
        /// <summary>
        /// 核对提示信息
        /// </summary>
        [XmlElement("check_msg")]
        public string CheckMsg { get; set; }

        /// <summary>
        /// 核对专用字段，核对通过:true 核对未通过:false
        /// </summary>
        [XmlElement("check_pass")]
        public bool CheckPass { get; set; }

        /// <summary>
        /// 平台统计已同步数据量
        /// </summary>
        [XmlElement("sync_count")]
        public long SyncCount { get; set; }
    }
}
