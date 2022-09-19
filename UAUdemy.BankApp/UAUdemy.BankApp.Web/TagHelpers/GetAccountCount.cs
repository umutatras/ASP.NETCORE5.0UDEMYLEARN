using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Linq;
using UAUdemy.BankApp.Web.Data.Context;

namespace UAUdemy.BankApp.Web.TagHelpers
{
    [HtmlTargetElement("getAccountCount")]
    public class GetAccountCount:TagHelper
    {
        private readonly BankContext _context;
        public  int ApplicatonUserId { get; set; }
        public GetAccountCount(BankContext context)
        {
            _context = context;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var accountCount = _context.Account.Count(x=>x.ApplicationUserId== ApplicatonUserId);
            var html = $"<span class='bagge bg-danger'>{accountCount}</span>";
           output.Content.SetHtmlContent(html);
        }
    }
}
