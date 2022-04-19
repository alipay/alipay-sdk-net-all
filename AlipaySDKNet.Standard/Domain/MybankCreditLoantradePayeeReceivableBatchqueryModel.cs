using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditLoantradePayeeReceivableBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradePayeeReceivableBatchqueryModel : AopObject
    {
        /// <summary>
        /// 业务场景，由网商端指定
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 查询订单ID列表，与其它过滤条件为且的关系
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("string")]
        public List<string> OrderList { get; set; }

        /// <summary>
        /// 页数，为空表示全量查询
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页面大小，为空表示全量查询
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 根据外部订单号查询，与其它过滤条件为且的关系
        /// </summary>
        [XmlArray("platform_order_list")]
        [XmlArrayItem("string")]
        public List<string> PlatformOrderList { get; set; }

        /// <summary>
        /// 查询状态列表，入参为空表示全部查询 WAIT_CONFIRM：待确认 RECEIVABLE：已生效且存在未收金额 DUE_RECEIVED：已全额到期自动收款 FACTORING_RECEIVED：已全额提前收款  UNVALID：失效
        /// </summary>
        [XmlArray("status_list")]
        [XmlArrayItem("string")]
        public List<string> StatusList { get; set; }

        /// <summary>
        /// 子场景，可空
        /// </summary>
        [XmlElement("sub_biz_scene")]
        public string SubBizScene { get; set; }

        /// <summary>
        /// 用户信息
        /// </summary>
        [XmlElement("user_info")]
        public CreditPayUserVO UserInfo { get; set; }
    }
}
