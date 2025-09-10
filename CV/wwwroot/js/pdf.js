window.cv = {
    print: function (filename) {
        const prevTitle = document.title;
        document.title = filename.replace(/\.pdf$/i, '');
        window.print();
        document.title = prevTitle;
    }
};