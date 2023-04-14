using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntProdpaasArrangementCommonQueryResponse.
    /// </summary>
    public class AntProdpaasArrangementCommonQueryResponse : AopResponse
    {
        /// <summary>
        /// 合约信息标准VO，一条合约一个记录
        /// </summary>
        [XmlArray("arrangements")]
        [XmlArrayItem("arrangement_v_o_res")]
        public List<ArrangementVORes> Arrangements { get; set; }
    }
}
