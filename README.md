# Ada_Homework

an api endpoint that rezervation train tickets

## Action


- localhost:5000/api/Train 
  > This Http Post action returns rezervation info based on input

## Example Input

{
    "Tren":
    {
        "Ad":"Başkent Ekspres",
        "Vagonlar":
        [
            {"Ad":"Vagon 1", "Kapasite":99, "DoluKoltukAdet":68},
            {"Ad":"Vagon 2", "Kapasite":90, "DoluKoltukAdet":50},
            {"Ad":"Vagon 3", "Kapasite":80, "DoluKoltukAdet":80},
            {"Ad":"Vagon 4", "Kapasite":99, "DoluKoltukAdet":68},
            {"Ad":"Vagon 5", "Kapasite":90, "DoluKoltukAdet":50},
            {"Ad":"Vagon 6", "Kapasite":80, "DoluKoltukAdet":80},
            {"Ad":"Vagon 7", "Kapasite":80, "DoluKoltukAdet":80},
            {"Ad":"Vagon 8", "Kapasite":99, "DoluKoltukAdet":68},
            {"Ad":"Vagon 9", "Kapasite":80, "DoluKoltukAdet":80},
            {"Ad":"Vagon 10", "Kapasite":80, "DoluKoltukAdet":80},
            {"Ad":"Vagon 11", "Kapasite":99, "DoluKoltukAdet":68},
            {"Ad":"Vagon 12", "Kapasite":90, "DoluKoltukAdet":50},
            {"Ad":"Vagon 13", "Kapasite":80, "DoluKoltukAdet":80},
            {"Ad":"Vagon 14", "Kapasite":99, "DoluKoltukAdet":68},
            {"Ad":"Vagon 15", "Kapasite":90, "DoluKoltukAdet":50},
            {"Ad":"Vagon 16", "Kapasite":80, "DoluKoltukAdet":80},
            {"Ad":"Vagon 17", "Kapasite":80, "DoluKoltukAdet":80},
            {"Ad":"Vagon 18", "Kapasite":99, "DoluKoltukAdet":68},
            {"Ad":"Vagon 19", "Kapasite":80, "DoluKoltukAdet":80},
            {"Ad":"Vagon 20", "Kapasite":80, "DoluKoltukAdet":80}
        ]
    },
    "RezervasyonYapilacakKisiSayisi":50,
    "KisilerFarkliVagonlaraYerlestirilebilir":true
}

## Success Response

![SuccessResp](https://user-images.githubusercontent.com/57454282/133416561-6aebfdf5-08bb-4960-9231-3a3c6e41ac38.jpg)

## Fail Response

![FailResp](https://user-images.githubusercontent.com/57454282/133416737-5b3133ab-5786-4b08-91b6-3978a3a445f5.jpg)

