using JetBrains.Annotations;
using VkNet.Abstractions.Utils;
using VkNet.Enums;
using VkNet.Model;

namespace VkNet.Infrastructure.Authorization.ImplicitFlow
{
	/// <inheritdoc />
	[UsedImplicitly]
	public sealed class ImplicitFlowLoginForm : AbstractAuthorizationForm
	{

		/// <inheritdoc />
		public ImplicitFlowLoginForm(IRestClient restClient, IAuthorizationFormHtmlParser htmlParser)
			: base(restClient, htmlParser)
		{
		}

		/// <inheritdoc />
		public override ImplicitFlowPageType GetPageType() => ImplicitFlowPageType.LoginPassword;

		/// <inheritdoc />
		protected override void FillFormFields(VkHtmlFormResult form, IApiAuthParams authParams)
		{
			if (form.Fields.ContainsKey(AuthorizationFormFields.Email))
			{
				form.Fields[AuthorizationFormFields.Email] = authParams.Login;
			}

			if (form.Fields.ContainsKey(AuthorizationFormFields.Password))
			{
				form.Fields[AuthorizationFormFields.Password] = authParams.Password;
			}
		}
	}
}