﻿using System;
using System.Collections.Generic;

namespace Project_Interview.Models;

public partial class MyofficeAcpd
{
    /// <summary>
    /// 使用者主鍵
    /// </summary>
    public string AcpdSid { get; set; } = null!;

    /// <summary>
    /// 中文名稱
    /// </summary>
    public string? AcpdCname { get; set; }

    /// <summary>
    /// 英文名稱
    /// </summary>
    public string? AcpdEname { get; set; }

    /// <summary>
    ///  簡稱
    /// </summary>
    public string? AcpdSname { get; set; }

    /// <summary>
    /// 使用者信箱
    /// </summary>
    public string? AcpdEmail { get; set; }

    /// <summary>
    /// 狀況 0=正常 , 99=不正常
    /// </summary>
    public byte? AcpdStatus { get; set; }

    /// <summary>
    ///  是否停用/不可登入
    /// </summary>
    public bool? AcpdStop { get; set; }

    /// <summary>
    /// 停用原因
    /// </summary>
    public string? AcpdStopMemo { get; set; }

    /// <summary>
    /// 登入帳號
    /// </summary>
    public string? AcpdLoginId { get; set; }

    /// <summary>
    /// 登入密碼
    /// </summary>
    public string? AcpdLoginPw { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? AcpdMemo { get; set; }

    /// <summary>
    /// 新增日期
    /// </summary>
    public DateTime? AcpdNowdatetime { get; set; }

    /// <summary>
    /// 新增人員代碼
    /// </summary>
    public string? AppdNowid { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime? AcpdUpddatetitme { get; set; }

    /// <summary>
    /// 修改人員代碼
    /// </summary>
    public string? AcpdUpdid { get; set; }
}
