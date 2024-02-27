const actualBtn = document.getElementsByClassName('custom-file-input');

const fileChosen1 = document.getElementById('file-chosen1');
const fileChosen2 = document.getElementById('file-chosen2');


actualBtn[0].addEventListener('change', function(){
  fileChosen1.textContent = this.files[0].name
})

actualBtn[1].addEventListener('change', function () {
    fileChosen2.textContent = this.files[0].name
})