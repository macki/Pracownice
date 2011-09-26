function showPhoto(url, changedIdPhoto, buttonOk, buttonBack, buttonChoseFile, fileLabel, buttonSetter) {
        var photo = document.getElementById(changedIdPhoto);
        photo.innerHTML = '<div id="PracownicaUniwersalnaCzcionka2"> Wybrano nowe zdjęcie profilowe, zatwierdź zmiany... </div>';

        //set visible ok
        document.getElementById(buttonOk).style.visibility = 'visible';

        //set viisble back
        document.getElementById(buttonBack).style.visibility = 'visible';

        //set hidden choosen file button
        document.getElementById(buttonChoseFile).style.visibility = 'hidden';
        document.getElementById(buttonChoseFile).style.display = 'none';

        document.getElementById(fileLabel).style.visibility = 'hidden';
        document.getElementById(fileLabel).style.display = 'none';

        //buttons setter
        document.getElementById(buttonSetter).style.display = 'inline-block';
    }

    function HideNewFile(url, changedIdPhoto, buttonOk, buttonBack, buttonChoseFile, fileLabel, buttonSetter) {

        var photo = document.getElementById(changedIdPhoto);
        photo.innerHTML = '<img src="' + url + '" />';

        document.getElementById(buttonOk).style.visibility = 'hidden';
        document.getElementById(buttonBack).style.visibility = 'hidden';

        document.getElementById(buttonChoseFile).style.visibility = 'visible';
        document.getElementById(buttonChoseFile).style.display = 'inline-block';

        document.getElementById(fileLabel).style.visibility = 'visible';
        document.getElementById(fileLabel).style.display = 'inline-block';

        //buttons setter
        document.getElementById(buttonSetter).style.display = 'none';
    }

    function HideOrShowProfilePhoto(elementId_Container, elementId_clickText)
    {
        if (document.getElementById(elementId_Container).style.visibility == 'visible')
        {
            document.getElementById(elementId_Container).style.visibility = 'hidden';
            document.getElementById(elementId_Container).style.height = '0px';

            document.getElementById(elementId_clickText).textContent = "Pokaż";
        }
        else
        {
            document.getElementById(elementId_Container).style.visibility = 'visible';
            document.getElementById(elementId_Container).style.height = 'auto';

            document.getElementById(elementId_clickText).textContent = "Ukryj";
        }
    }

    