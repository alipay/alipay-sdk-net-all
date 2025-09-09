using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchInstSignalSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchInstSignalSyncModel : AopObject
    {
        /// <summary>
        /// valueFactor String 原始因子值 valueRank int 行业排名，排名取1-45 valueSig int 上车信号1-可上车、0-中性、-1-有风险 industryCode String 行业指数，见“4、行业指数字典”
        /// </summary>
        [XmlArray("datas")]
        [XmlArrayItem("inst_sig_config_info")]
        public List<InstSigConfigInfo> Datas { get; set; }

        /// <summary>
        /// 蚂蚁财富对于公募基金在财富号后台生成的机构号，可以跟蚂蚁财富对接技术申请获取
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }
    }
}
