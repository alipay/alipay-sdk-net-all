using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinMortgageresubmitNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinMortgageresubmitNotifyModel : AopObject
    {
        /// <summary>
        /// 协议文件
        /// </summary>
        [XmlArray("agreement_file_list")]
        [XmlArrayItem("agreement_file")]
        public List<AgreementFile> AgreementFileList { get; set; }

        /// <summary>
        /// 星河侧唯一申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 需要替换的审核文件列表
        /// </summary>
        [XmlArray("approve_file_list")]
        [XmlArrayItem("carfin_mortgage_received_file")]
        public List<CarfinMortgageReceivedFile> ApproveFileList { get; set; }

        /// <summary>
        /// 星河侧唯一支用申请单号
        /// </summary>
        [XmlElement("lend_apply_no")]
        public string LendApplyNo { get; set; }

        /// <summary>
        /// 星河侧唯一抵押订单号
        /// </summary>
        [XmlElement("mortgage_no")]
        public string MortgageNo { get; set; }

        /// <summary>
        /// 机构侧唯一业务编号
        /// </summary>
        [XmlElement("out_apply_no")]
        public string OutApplyNo { get; set; }

        /// <summary>
        /// 机构侧唯一支用申请单号
        /// </summary>
        [XmlElement("out_lend_apply_no")]
        public string OutLendApplyNo { get; set; }

        /// <summary>
        /// 重推时替换的车辆信息
        /// </summary>
        [XmlElement("vehicle_info")]
        public CarfinMortgageVehicleInfo VehicleInfo { get; set; }
    }
}
