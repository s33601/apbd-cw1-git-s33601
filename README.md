Poczatek prac nad projektem APBD

1. W Zadaniu 5 merge nie jest fast-forward, ponieważ to zrobieniu nowej gałęzi feature-max, do maina zostały dodane inne commity, które były niezależne. Historie obu gałęzi się powiększyły, więc git stworzył nowy merg commit, aby je połączyć.

Dodano przygotowanie do rebase

2. Merge tworzy nowy commit łączący oddzielnie historie, rebase odcina nową głąź i dokleja ją na samym końcu gałęzi głównej. Dzięki temu przy łączeniu zawsze mamy fast-forward, a historia jest prosta i czytelna.

3. Konflikt, który powstawał w StatisticsHelper.cs przez edytowanie tej samej linnijki w main oraz gałęzi bocznej rozwiązałem przed otwarcie tego pliku ręcznie oraz ręczne usunięcie stary komentarzy, które były w tym samym miejscu w raz ze znakami, które dodały oraz dodaniem nowego zupelnie nowego komentarza, żeby coś tam się jednak znalazło.