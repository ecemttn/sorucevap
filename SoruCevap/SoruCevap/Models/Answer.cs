
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace SoruCevap.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Answer
{

    public string aId { get; set; }

    public string aBody { get; set; }

    public string aUserId { get; set; }

    public string aQId { get; set; }



    public virtual Question Question { get; set; }

    public virtual User User { get; set; }

}

}