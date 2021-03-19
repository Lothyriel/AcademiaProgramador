package Academia_do_Programador;

import java.time.LocalTime;

/**
 * @author JX
 */
public class Equipamentos {
    private String nome;
    private double preco;
    private int nro_serie;

    public Equipamentos(String nome, double preco, int nro_serie, LocalTime data_fabricacao, String fabricante) {
        this.nome = nome;
        this.preco = preco;
        this.nro_serie = nro_serie;
        this.data_fabricacao = data_fabricacao;
        this.fabricante = fabricante;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public double getPreco() {
        return preco;
    }

    public void setPreco(double preco) {
        this.preco = preco;
    }

    public int getNro_serie() {
        return nro_serie;
    }

    public void setNro_serie(int nro_serie) {
        this.nro_serie = nro_serie;
    }

    public LocalTime getData_fabricacao() {
        return data_fabricacao;
    }

    public void setData_fabricacao(LocalTime data_fabricacao) {
        this.data_fabricacao = data_fabricacao;
    }

    public String getFabricante() {
        return fabricante;
    }

    public void setFabricante(String fabricante) {
        this.fabricante = fabricante;
    }
    private LocalTime data_fabricacao;
    private String fabricante;
}
