
const initSilider = () => {

    const imageList = document.querySelector(".container .content_box .content .slider-wrapper .image-list");
    const sliderButtons = document.querySelectorAll(".container .content_box .slider-wrapper .slide-button");
    const maxScrollLeft = imageList.scrollWidth - imageList.clientWidth;
    sliderButtons.forEach(button => {
        button.addEventListener("click", () => {
            const direction = button.id == "prev-slide" ? -1 : 1;
            const scrollAmount = imageList.clientWidth * direction;
            imageList.scrollBy({ left: scrollAmount, behavior: "smooth" })

        })
    })

    const handleSlideButtons = () => {
        sliderButtons[0].style.display = imageList.scrollLeft <= 0 ? "nonde" : "block";
        sliderButtons[1].style.display = imageList.scrollLeft >= maxScrollLeft ? "nonde" : "block";
    }
    imageList.addEventListener("scroll", () => {
        handleSlideButtons();
    });
}

window.addEventListener("load", initSilider)