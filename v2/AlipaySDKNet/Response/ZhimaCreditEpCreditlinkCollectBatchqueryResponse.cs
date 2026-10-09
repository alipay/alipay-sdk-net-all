using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkCollectBatchqueryResponse.
    /// </summary>
    public class ZhimaCreditEpCreditlinkCollectBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 数据列表，其中list是JSON数据列表，目前只有招投标数据,其单项结构是  {   "agentUnit": "XX招标代理有限公司",   "areaCity": "B市",   "areaCountry": "C区",   "areaProvince": "A省",   "biddingType": "0",   "budget": "",   "infoFile": [],   "infoId": "123",       "infoPublishTime": "2021-11-12 18:02:48",     "infoTitle": "XXX成交结果公告",   "infoType": "3",   "infoTypeSegment": "11",   "isElectronic": "0",   "winnerAmount": "878000.00",   "zhaoBiaoUnit": "XXX信息中心",   "zhongBiaoUnit": "XXX分公司" }
        /// </summary>
        [XmlElement("contents")]
        public string Contents { get; set; }

        /// <summary>
        /// 当前请求的页码，和入参中的页码保持一致
        /// </summary>
        [XmlElement("cur_page_number")]
        public long CurPageNumber { get; set; }

        /// <summary>
        /// 数据采集状态，只有值为"END"才表示数据采集完成（包含没数据的情况，不存在数据也被认为是正常采集动作）。INIT表示任务还在初始化状态，COLLECT表示任务在进行中，FAIL表示任务处理失败。
        /// </summary>
        [XmlElement("data_status")]
        public string DataStatus { get; set; }

        /// <summary>
        /// 数据类型，和传入的数据类型保持一致
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 商户单号，和入参中的商户单号保持一致
        /// </summary>
        [XmlElement("merchant_request_id")]
        public string MerchantRequestId { get; set; }

        /// <summary>
        /// 查询的总条数，此数据只有在data_status为"END"状态才有意义。为0，则表示未采集到有效数据
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 页码总数，商户根据此数据判定是否继续翻页操作获取数据。此数据只有在data_status为"END"状态才有意义。为0，则表示未采集到有效数据
        /// </summary>
        [XmlElement("total_page_number")]
        public long TotalPageNumber { get; set; }
    }
}
