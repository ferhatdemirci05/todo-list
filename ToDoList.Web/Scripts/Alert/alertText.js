var alertText = {
	general: {
		success: {
			type: 'success',
			text: 'Başarılı',
		},
		failed: {
			type: 'danger',
			text: 'Başarısız',
		}
	},
	ajax: {
		success: {
			type: 'success',
			text: 'Sorgu Başarılı',
		},
		error: {
			type: 'danger',
			text: 'Sorgu Başarısız',
		},
		complete: {
			type: 'info',
			text: 'Sorgu Tamamlandı',
		}
	},
	fileUpload: {
		fileHasError: {
			type: 'danger',
			text: 'Hatalı medya'
		},
		fileExtensionNotSupported: {
			type: 'danger',
			text: 'Dosya uzantısı desteklenmiyor'
		},
		fileNameIsTooShort: {
			type: 'warning',
			text: 'Dosya adı çok kısa'
		},
		fileNameIsTooLong: {
			type: 'danger',
			text: 'Dosya adı çok uzun'
		},
		fileSaved: {
			type: 'success',
			text: 'Dosya kaydedildi'
		},
		fileDeleted: {
			type: 'success',
			text: 'Dosya silindi'
		},
		validationFileNameRequired: {
			type: 'warning',
			text: 'Dosya adı giriniz'
		}
	},
	form: {
        FormHasRequiredArea: {
            type: 'danger',
            text: 'Formda eksik, hatalı ya da doğrulanmamış alanlar mevcut lütfen kontrol ediniz'
        },
        formSubmitSuccess: {
            type: 'success',
            text: 'Form başarıyla gönderildi ve bilgiler kaydedildi'
        },
        formSubmitFailed: {
            type: 'danger',
            text: 'Form gönderilemedi ve bilgileriniz kaydedilemedi lütfen tekrar deneyiniz'
        },
        querySuccess: {
            type: 'success',
            text: 'Sorgu başarıyla <strong>çalıştırıldı</strong> ve <strong>veri alındı.</strong>'
        },
        queryFailed: {
            type: 'danger',
            text: 'Sorgu sunucu taraflı bir hatadan kaynaklı çalıştırılamadı. Lütfen <strong>gönderim parametrelerini</strong> kontrol ediniz.'
        },
        validationFalse: {
            type: 'danger',
            text: 'Formda eksik ya da doğrulanmamış alanlar mevcut lütfen kontrol ediniz'
        },
        redirecting: {
            type: 'info',
            text: 'Form gönderme işlemi sonrasında yönlendiriliyorsunuz. Lütfen bekleyin'
        },
        reloading: {
            type: 'info',
            text: 'Lütfen bekleyiniz'
        }
	},
	shortCategory: {
		failed: {
			type: 'danger',
			text: 'Üst Kategori Görünür Durumda Değil !',
		}
	},
	productRival: {
		recordCouldNotBeAdded: {
			type: 'danger',
			text: 'İlgili Rakip Fiyatını Güncellemek İçin Eklemeniz Gerek !',
		},
		recordCouldNotSelectedBySubstitute: {
			type: 'danger',
			text: 'Lütfen Rakip Ürün URL Değerini Kaydediniz!',
		},
		recordCouldNotBeReflesh: {
			type: 'danger',
			text: 'Fiyat Güncellemesi İçin İlk Olarak Yeni Link Eklenmeli !',
		}
	},
	NotRecord: {
		type:'warning',
		text:'Böyle bir kayıt mevcut değil. Liste sayfasına yönlendiriliyorsunuz.'
	},
	Notifications: {
		enterAValueForSearch: {
			type: 'warning',
			text: 'Değer giriniz'
		}
	},
	productType: {
		productTypeNotSelected: {
			type: 'warning',
			text: 'Lütfen Ürün Tipi Seçimi Yapınız.'
		}
	},
	searchRule: {
		actionNotDeleted: {
			type: 'warning',
			text: 'Lütfen Alt Kuralı Siliniz.'
		},
		keywordNotDeleted: {
			type: 'warning',
			text: 'Lütfen İlk Olarak Kuralları Siliniz.'
		},
		multipleBrandDontSelected: {
			type: 'warning',
			text: 'Marka kuralı altında, birden fazla marka seçilemez.'
		},
		multipleCategoryDontSelected: {
			type: 'warning',
			text: 'Kategori kuralı altında, birden fazla kategori seçilemez.'
		}
	},
	productAddbrandSelect: {
		productTypeNotSelected: {
			type: 'warning',
			text: 'Lütfen Marka Seçimi Yapınız.'
		}
	},
	productAddproductTitle: {
		productTypeNotSelected: {
			type: 'warning',
			text: 'Lütfen Ürün Adı Giriniz.'
		}
	},
	productAddbarcode: {
		productTypeNotSelected: {
			type: 'warning',
			text: 'Lütfen Barkod Numarası Giriniz.'
		}
	},
	productAddmoneyUnitPurchase: {
		productTypeNotSelected: {
			type: 'warning',
			text: 'Lütfen Para Birimi (Alış) Giriniz.'
		}
	},
	productAddmoneyUnitSale: {
		productTypeNotSelected: {
			type: 'warning',
			text: 'Lütfen Para Birimi (Satış) Giriniz.'
		}
	},
	productAdddepartment: {
		productTypeNotSelected: {
			type: 'warning',
			text: 'Lütfen Departman Seçiniz.'
		}
	},
	productAddCategory: {
		productTypeNotSelected: {
			type: 'warning',
			text: 'Lütfen Kategori Seçiniz.'
		}
	},
	productAddSaleRegions: {
		productTypeNotSelected: {
			type: 'warning',
			text: 'Lütfen Satılabilen Bölge Seçiniz.'
		}
	},
	productAddStockTitle: {
		productTypeNotSelected: {
			type: 'warning',
			text: 'Lütfen Stok Adı Giriniz.'
		}
	},
	productPageCategory: {
		productCategoryNotSelected: {
			type: 'warning',
			text: 'Lütfen Kategori Seçimi Yapınız.'
		}
	},
	productPageCategory: {
		productCategoryNotSelected: {
			type: 'warning',
			text: 'Lütfen Kategori Seçimi Yapınız.'
		}
	}

}
