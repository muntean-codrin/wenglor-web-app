using Microsoft.AspNetCore.Components;

namespace WenglorWebApp
{
    public class ImagesLoaderService
    {
        private readonly NavigationManager _navigationManager;
        private readonly HttpClient _httpClient;

        private bool imagesLoaded = false;
        private List<Image> imageList;

        public List<Image> Images
        {
            get
            {
                return imageList;
            }
        }

        public ImagesLoaderService(NavigationManager navigationManager, HttpClient httpClient)
        {
            _navigationManager = navigationManager;
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri(_navigationManager.BaseUri);
            imageList = new List<Image>();
        }

        public async Task<bool> LoadImages()
        {
            if (imagesLoaded)
                return true;

            for (int i = 0; i <= 9999; i++)
            {
                var image = new Image($"{i:0000}.bmp");
                if (!await ImageExists(image.ReferencePath))
                    break;
                imageList.Add(image);
            }

            if (imageList.Count > 0)
                imagesLoaded = true;

            return imagesLoaded;
        }

        private async Task<bool> ImageExists(string imageUrl)
        {
            var request = new HttpRequestMessage(HttpMethod.Head, imageUrl);
            var response = await _httpClient.SendAsync(request);
            return response.IsSuccessStatusCode;
        }
    }
}
