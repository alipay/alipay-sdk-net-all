using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantQipanBoardQueryResponse.
    /// </summary>
    public class AlipayMerchantQipanBoardQueryResponse : AopResponse
    {
        /// <summary>
        /// 人群看板分析数据
        /// </summary>
        [XmlArray("index_list")]
        [XmlArrayItem("board_index")]
        public List<BoardIndex> IndexList { get; set; }
    }
}
