Poczatek prac nad projektem APBD

1. W Zadaniu 5 merge nie jest fast-forward, ponieważ to zrobieniu nowej gałęzi feature-max, do maina zostały dodane inne commity, które były niezależne. Historie obu gałęzi się powiększyły, więc git stworzył nowy merg commit, aby je połączyć.

Dodano przygotowanie do rebase

2. Merge tworzy nowy commit łączący oddzielnie historie, rebase odcina nową głąź i dokleja ją na samym końcu gałęzi głównej. Dzięki temu przy łączeniu zawsze mamy fast-forward, a historia jest prosta i czytelna.