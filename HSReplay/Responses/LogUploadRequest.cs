using Newtonsoft.Json;

namespace HSReplay.Responses
{
	/// <summary>
	/// Response from POST to https://upload.hsreplay.net/api/v1/replay/upload/request
	/// </summary>
	public class LogUploadRequest
	{
		[JsonProperty("put_url")]
		public string PutUrl { get; set; }

		[JsonProperty("shortid")]
		public string ShortId { get; set; }

		[JsonProperty("descriptor_url")]
		public string DescriptorUrl { get; set; }
	}
}