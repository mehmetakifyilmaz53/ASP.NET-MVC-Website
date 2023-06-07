
    function deleteProduct(productId) {
        // AJAX isteği ile ürünü silmek için sunucu tarafına gönderim yapabilirsiniz.
        // Örneğin, jQuery kullanarak bir AJAX isteği gönderelim:
        $.ajax({
            url: '/Product/Delete', // Silme işlemini gerçekleştirecek yönlendirme URL'si
            type: 'POST',
            data: { productId: productId }, // Silinecek ürünün ProductId'sini veri olarak gönderiyoruz
            success: function(result) {
                // Silme işlemi başarılı olduysa, gerekli işlemleri burada gerçekleştirebilirsiniz
                // Örneğin, sayfayı yenilemek gibi
                location.reload(); // Sayfayı yenile
            },
            error: function(xhr, status, error) {
                // Hata durumunda gereken işlemleri burada gerçekleştirebilirsiniz
                console.log('Hata:', error);
            }
        });
    }

