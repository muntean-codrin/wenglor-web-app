var inputImg, outputImg;

function openModal(img1, img2) {
    inputImg = img1;
    outputImg = img2;
    var modal = document.getElementById("myModal");
    var image = document.getElementById("modal-image");
    var button = document.getElementById("modal-change-picture");
    image.src = img1;
    modal.style.display = "block";
    button.textContent = "Show denoised image";
}

function changePicture() {
    var image = document.getElementById("modal-image");
    var button = document.getElementById("modal-change-picture");
    if (image.src.slice(-14) == inputImg.slice(-14)) {
        image.src = outputImg;
        button.textContent = "Show inital image";
    }

    else {
        image.src = inputImg;
        button.textContent = "Show denoised image";
    }
}

function closeModal() {
    var modal = document.getElementById("myModal");
    modal.style.display = "none";
}

function openImageInNewTab(imageUrl) {
    window.open(imageUrl, '_blank');
}